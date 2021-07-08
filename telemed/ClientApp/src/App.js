import React, { Component } from 'react';
import { ChartComponent } from './ChartComponent';

import './App.css';

const token = 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.CNHY4yVQsvkeAQVNU29sYj-7OEPIjdRr4ursq3yF5sg';

export default class Temperature extends Component {
    constructor() {
        super();
        this.state = { temperatures: [] };
    }

    componentDidMount() {
        fetch('https://telemedycyna.azurewebsites.net/temperature', {
            method: 'GET',
            mode: 'cors',
            headers: {
                'Content-Type': 'application/json',
                Token: token,
            },
        })
            .then(response => response.json())
            .then(json => this.setState({ temperatures: json }));
    }

    render() {
        return (
            <>
                {this.state.temperatures.length ? (
                    <div style={{ height: '500px' }}>
                        <ChartComponent data={this.state.temperatures} />
                    </div>
                ) : (
                    <div>Loading...</div>
                )}
            </>
        );
    }
}
