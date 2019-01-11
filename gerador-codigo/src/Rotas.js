import React from "react";

import { Gerador } from "./pages";

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
        }
    ];

    return rotas;
}

export default GetRotas();