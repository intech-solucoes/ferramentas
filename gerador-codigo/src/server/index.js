var express = require('express');
var bodyParser = require('body-parser')
var cors = require("cors");
var { filesystem } = require("gluegun");

var app = express();

app.use(bodyParser.urlencoded({ extended: false }))
app.use(bodyParser.json())

app.use(cors());

app.get('/conexoes', async (req, res) => {
    var dirConexoes = await filesystem.listAsync("./src/config/conexoes");
    var conexoes = [];

    dirConexoes.forEach((conexao) => {
        conexoes.push(conexao.split('.')[0]);
    });

    res.json(conexoes);
});

app.get('/config', async (req, res) => {
    var configFile = getUserConfig(false);

    if(configFile)
        configFile = JSON.parse(configFile);
    else
        configFile = null;

    res.json(configFile);
});

app.post('/config', async (req, res) => {
    var configFile = {
        baseGit: req.body.baseGit
    };

    var configFilepath = getUserConfigPath();

    filesystem.write(configFilepath, configFile);

    res.end();
});

app.get('/sistemas', async (req, res) => {
    var sistemas = await getSistemas();

    res.json(sistemas);
});

app.get('/sistemas/:nome', async (req, res) => {
    var sistemas = await getSistemas();
    
    var sistema = sistemas.filter((sistema) => {
        return sistema.nome === req.params.nome;
    });

    res.json(sistema[0]);
});

app.post('/entidades', async (req, res) => {
    var configFile = getUserConfig();
    
    var diretorio = req.body.diretorio.replace("${baseGit}", configFile.baseGit);
    var entidades = filesystem.list(diretorio).filter((x) => x !== ".DS_Store");

    res.json(entidades);
});

app.listen(9999, () => {
    console.log('Listening on 9999');
});

//////////////////////////
// Funções ///////////////
//////////////////////////

getSistemas = async () => {
    var fileSistemas = await filesystem.readAsync("./src/config/sistemas.json");
    fileSistemas = JSON.parse(fileSistemas);

    return fileSistemas.sistemas;
}

getUserConfigPath = () => {
    var userPath = filesystem.homedir();
    var intechPath = filesystem.path(userPath, 'Intech');

    filesystem.dir(intechPath);

    var configFilePath = filesystem.path(intechPath, 'user_config.json');

    return configFilePath;
}

getUserConfig = (parse = true) => {
    var configFilepath = getUserConfigPath();

    var configFile = filesystem.read(configFilepath);

    if(parse)
        configFile = JSON.parse(configFile);

    return configFile;
}