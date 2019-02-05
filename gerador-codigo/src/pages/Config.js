import React, { Component } from "react";
import { Box, Row, Col, Button, CampoTexto } from "@intechprev/componentes-web";
import axios from "axios";
import Checkbox from "rc-checkbox";
import 'rc-checkbox/assets/index.css';

import { MasterPage } from "./";

const baseUrl = "http://localhost:9999";

export default class Config extends Component {

    state = {
        config: {
            baseGit: ""
        }
    }

    constructor(props) {
        super(props);

        this.page = React.createRef();
    }

    componentDidMount = async () => {
        var { data: config } = await axios({
            method: "GET",
            url: `${baseUrl}/config`
        });

        if(config) {
            await this.setState({
                config
            })
        }
    }

    salvar = async () => {
        try {
            var { data: result } = await axios({
                method: "POST",
                url: `${baseUrl}/config`,
                data: this.state.config
            });

            alert("Configurações salvas com sucesso!");
        } catch(ex) {
            alert("Ocorreu um erro ao tentar salvar as configurações!");
        }
    }

    render() {
        return (
            <MasterPage {...this.props} ref={this.page}>
                
                <Box titulo={"Configurações"}>
                    
                    <CampoTexto nome={"baseGit"} contexto={this}
                                label={"Diretório do repositório:"} obrigatorio={true}
                                parent={"config"} valor={this.state.config.baseGit} />

                    <Button titulo={"Salvar"} tipo={"success"} onClick={this.salvar} />
                    
                </Box>

            </MasterPage>
        );
    }
    
}