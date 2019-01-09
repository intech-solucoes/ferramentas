import React from "react";

import { Home } from "./pages";

function GetRotas() {
    const rotas = [
        {
            titulo: "Home",
            icone: "fas fa-home",
            caminho: "/",
            componente: routeProps => <Home {...routeProps} />,
            mostrarMenu: true,
            exact: true,
            id: "home"
        }
    ];

    return rotas;
}

export default GetRotas();