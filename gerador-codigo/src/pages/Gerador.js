import React, { Component } from "react";
import { Box, Row, Col, Button } from "@intechprev/componentes-web";
import axios from "axios";
import Checkbox from "rc-checkbox";
import 'rc-checkbox/assets/index.css';

import { MasterPage } from "./";

const baseUrl = "http://localhost:9999";

export default class Gerador extends Component {

    state = {
        conexoes: null,
        sistemas: null,
        sistema: {},
        conexao: "",
        config: {},
        listaProjetos:[],
        gerarEntidade: true,
        gerarDAO: true,
        gerarProxy: true
    }

    constructor(props) {
        super(props);

        this.page = React.createRef();
    }

    componentDidMount = async () => {
        var { data: conexoes } = await axios({
            method: "GET",
            url: `${baseUrl}/conexoes`
        });

        var { data: sistemas } = await axios({
            method: "GET",
            url: `${baseUrl}/sistemas`
        });

        var { data: config } = await axios({
            method: "GET",
            url: `${baseUrl}/config`
        });

        if(!config)
        {
            this.props.history.push('/Config');
            return;
        }

        await this.setState({
            conexoes,
            sistemas,
            sistema: sistemas[0],
            conexao: conexoes[0],
            config
        });

        await this.buscarEntidades();
    }

    onChange = async (e) => {
        await this.setState({
            [e.target.name]: e.target.checked
        });
    }

    selecionarSistema = async (e) => {
        await this.setState({
            sistema: this.state.sistemas[e.target.value]
        });

        await this.buscarEntidades();
    }

    selecionarConexao = async (e) => {
        await this.setState({
            conexao: this.state.conexoes[e.target.value]
        });
    }

    buscarEntidades = async () => {
        var { data: entidades } = await axios({
            method: "POST",
            url: `${baseUrl}/entidades`,
            data: { 
                diretorio: `${this.state.sistema.diretorios.dados}/Scripts`
            }
        });
        
        await this.setState({
            entidades
        });
    }

    render() {
        return (
            <div>
                <MasterPage {...this.props} ref={this.page}>
                    
                    <Box titulo={"Gerador"}>
                        
                        <Row>
                            <Col>
                                <Row formGroup>
                            
                                    <Col tamanho={"lg-12"} className={"col-form-label"}>
                                        <label htmlFor={this.props.nome}>
                                            Sistema
                                        </label>
                                    </Col>

                                    <Col>
                                        {this.state.sistemas &&
                                            <select className={"form-control"} onChange={this.selecionarSistema}>
                                                {this.state.sistemas.map((sistema, index) => {
                                                    return <option key={index} value={index}>{sistema.nome}</option>
                                                })}
                                            </select>
                                        }
                                    </Col>

                                </Row>
                            </Col>
                            
                            <Col>
                                <Row formGroup>
                            
                                    <Col tamanho={"lg-12"} className={"col-form-label"}>
                                        <label htmlFor={this.props.nome}>
                                            Conexão
                                        </label>
                                    </Col>

                                    <Col>
                                        {this.state.conexoes &&
                                            <select className={"form-control"} onChange={this.selecionarConexao}>
                                                {this.state.conexoes.map((conexao, index) => {
                                                    return <option key={index} value={index}>{conexao}</option>
                                                })}
                                            </select>
                                        }
                                    </Col>

                                </Row>
                            </Col>
                        </Row>

                    </Box>

                    <Box>
                        {this.state.entidades && this.state.entidades.map((entidade, index) => {
                            return <li>{entidade}</li>;
                        })}
                    </Box>
                    <br/>
                    <br/>

                </MasterPage>

                <div className={"float-panel"}>
                    <Row>
                        <Col tamanho={"2"} className={"mt-2"}>
                            <Checkbox name={"gerarEntidade"} checked={this.state.gerarEntidade} onChange={this.onChange} />
                            &nbsp; Entidade
                        </Col>
                        <Col tamanho={"2"} className={"mt-2"}>
                            <Checkbox name={"gerarDAO"} checked={this.state.gerarDAO} onChange={this.onChange} />
                            &nbsp; DAO
                        </Col>
                        <Col tamanho={"2"} className={"mt-2"}>
                            <Checkbox name={"gerarProxy"} checked={this.state.gerarProxy} onChange={this.onChange} />
                            &nbsp; Proxy
                        </Col>
                        <Col tamanho={"2"} className={"offset-md-4"}>
                            <Button titulo={"Gerar"} tipo={"primary"} block />
                        </Col>
                    </Row>
                </div>
            </div>
        );
    }

}