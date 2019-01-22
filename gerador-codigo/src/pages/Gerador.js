import React, { Component } from "react";
import { Box, Row, Col, Button } from "@intechprev/componentes-web";
import { filesystem } from "gluegun";
import Checkbox from "rc-checkbox";
import 'rc-checkbox/assets/index.css';

import { MasterPage } from "./";

export default class Gerador extends Component {

    state = {
        gerarEntidade: true,
        gerarDAO: true,
        gerarProxy: true
    }

    constructor(props) {
        super(props);

        this.page = React.createRef();
    }

    componentDidMount = async () => {
        var conexoes = await filesystem.listAsync("../config/conexoes");
        console.log(conexoes);
    }

    onChange = async (e) => {
        await this.setState({
            [e.target.name]: e.target.checked
        });
    }

    render() {
        return (
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
                                    <select className={"form-control"}>
                                        <option>Teste</option>
                                    </select>
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
                                    <select className={"form-control"}>
                                        <option>Teste</option>
                                    </select>
                                </Col>

                            </Row>
                        </Col>
                    </Row>

                </Box>

                <Box>

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

                </Box>

            </MasterPage>
        );
    }

}