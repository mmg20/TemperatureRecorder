import React, { Component } from 'react';
import { Line } from 'react-chartjs-2';

import './ChartComponent.css';

export class ChartComponent extends Component {
    getTimestamp(stringDate) {
        return new Date(stringDate)
            .toLocaleString();
    }

    getDataPoints() {
        return this.props.data
            .sort((a, b) => (Date.parse(a.timestamp) > Date.parse(b.timestamp)) ? 1 : -1)
            .map(t => ({ t: t.timestamp, y: t.value }));
    }

    render() {
        return (
            <Line
                data={{
                    datasets: [{
                        label: 'Temperatura w °C',
                        data: this.getDataPoints(),
                        borderColor: 'red',
                        backgroundColor: 'red',
                        pointRadius: 0,
                        pointHitRadius: 0,
                        pointHoverRadius: 0,
                        fill: false,
                        lineTension: 0.4,
                        borderWidth: 3,
                    }]
                }}
                options={{
                    title: {
                        display: true,
                        text: `Temperatura w ${this.props.data[0].location}, sensor: ${this.props.data[0].sensorName}`
                    },
                    tooltips: {
                        mode: 'index',
                        intersect: false,
                        callbacks: {
                            label: function (tooltipItem, data) {
                                return `${tooltipItem.yLabel} °C`;
                            }
                        }
                    },
                    hover: {
                        mode: 'index',
                        intersect: false,
                    },
                    layout: {
                        padding: {
                            left: 50,
                            right: 100,
                            top: 50,
                            bottom: 100
                        }
                    },
                    scales: {
                        xAxes: [{
                            type: 'time',
                            display: true,
                            time: {
                                unit: 'minute',
                                tooltipFormat: 'HH:mm:ss',
                                displayFormats: {
                                    minute: 'HH:mm',
                                }
                            },
                        }],
                        yAxes: [{
                            display: true,
                            ticks: {
                                min: -40,
                                max: 60,
                                stepSize: 10
                            }
                        }]
                    },
                }}
            />
        )
    }
}