import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter, Switch, Route } from "react-router-dom";
import Rotas from "./Rotas";

class MainRender extends Component {
	render() {
		return (
			<BrowserRouter>
				<Switch>
					{ Rotas.map((rota, index) => <Route key={index} exact={rota.exact} path={rota.caminho} component={rota.componente} />) }
				</Switch>
			</BrowserRouter>
		);
	}
}

ReactDOM.render(<MainRender />, document.getElementById("root"));