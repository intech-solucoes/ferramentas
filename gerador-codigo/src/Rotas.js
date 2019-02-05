import React from "react";

import { Gerador, Config } from "./pages";

function GetRotas() {
    const rotas = [
        {
            titulo: "Gerador",
            icone: "fas fa-code",
            caminho: "/",
            componente: routeProps => <Gerador {...routeProps} />,
            mostrarMenu: true,
            exact: true,
            id: "gerador"
        },
        {
            titulo: "Configuração",
            icone: "fas fa-cog",
            caminho: "/config",
            componente: routeProps => <Config {...routeProps} />,
            mostrarMenu: true,
            exact: true,
            id: "config"
        }
    ];

    return rotas;
}

export default GetRotas();