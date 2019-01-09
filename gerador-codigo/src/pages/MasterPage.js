import React, { Component } from 'react';
import { Link } from "react-router-dom";

import Rotas from "../Rotas";

export default class MasterPage extends Component {

	render() {
		return (
			<div>

				<div className="wrapper">
                    <nav className="navbar-default nav-open">
                        <ul>
                            {
                                Rotas.map((rota, index) => {
                                    var link = rota.caminhoLink ? rota.caminhoLink : rota.caminho;

                                    if(rota.mostrarMenu) {
                                        return (
                                            <li key={index}>
                                                <Link to={link}>
                                                    <i className={rota.icone}></i>
                                                    {rota.titulo}
                                                </Link>
                                            </li>
                                        );
                                    }
                                    else return "";
                                })
                            }
                            <li>
                                <a href="." onClick={this.selecionarContribuinte}>
                                    <i className="fas fa-exchange-alt"></i>
                                    Selecionar Contribuinte
                                </a>
                            </li>

                            <li>
                                <a href="." onClick={this.logout}>
                                    <i className="fas fa-sign-out-alt"></i>
                                    Sair
                                </a>
                            </li>
                        </ul>
                    </nav>

                    <div className="page-wrapper nav-open">
                        <div className="wrapper-content">

                            {this.props.children}

                        </div>
                    </div>
                </div>
				
			</div>
		);
	}
	
}