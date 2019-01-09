import React, { Component } from "react";
import { MasterPage } from "./";

export default class Home extends Component {

    constructor(props) {
        super(props);

        this.page = React.createRef();
    }

    render() {
        return (
            <MasterPage {...this.props} ref={this.page}>
                Home
            </MasterPage>
        );
    }

}