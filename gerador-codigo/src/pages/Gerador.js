import React, { Component } from "react";
import { Box } from "@intechprev/componentes-web";

import { MasterPage } from "./";

export default class Gerador extends Component {

    constructor(props) {
        super(props);

        this.page = React.createRef();
    }

    render() {
        return (
            <MasterPage {...this.props} ref={this.page}>
                
                <Box>
                    Gerador
                </Box>

            </MasterPage>
        );
    }

}