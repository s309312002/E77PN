/*=========================================================================================
    File Name: column.js
    Description: Chartjs column chart
    ----------------------------------------------------------------------------------------
    Item Name: Chameleon Admin - Modern Bootstrap 4 WebApp & Dashboard HTML Template + UI Kit
    Version: 1.0
    Author: ThemeSelection
    Author URL: https://themeselection.com/
==========================================================================================*/

// Column chart
// ------------------------------
$(window).on("load", function(){

    //Get the context of the Chart canvas element we want to select
    var ctx = $("#column-chart");

    // Chart Options
    var chartOptions = {
        // Elements options apply to all of the options unless overridden in a dataset
        // In this case, we are setting the border of each bar to be 2px wide and green
        elements: {
            rectangle: {
                borderWidth: 2,
                borderColor: 'rgb(0, 255, 0)',
                borderSkipped: 'bottom'
            }
        },
        responsive: true,
        maintainAspectRatio: false,
        responsiveAnimationDuration:500,
        
        scales: {
            xAxes: [{
                display: true,
                gridLines: {
                    color: "#f3f3f3",
                    drawTicks: false,
                },
                scaleLabel: {
                    display: true,
                }
            }],
            yAxes: [{
                display: true,
                gridLines: {
                    color: "#f3f3f3",
                    drawTicks: false,
                },
                scaleLabel: {
                    display: true,
                }
            }]
        }
    };

    // Chart Data
    var chartData = {
        labels: ["2016年", "2017年", "2018年", "2019年", "2020年"],
        datasets: [{
            label: "淨攤",
            data: [25, 24, 33, 32, 29],
            backgroundColor: " #88F2F2",
            hoverBackgroundColor: "#77d9d9",
            borderColor: "transparent"
        }, {
            label: "淨山",
            data: [15, 16, 17, 19, 18],
            backgroundColor: "#0AA696",
            hoverBackgroundColor: "#05877a",
            borderColor: "transparent"
        },{
            label: "淨路",
            data: [22, 20, 21, 26, 31],
            backgroundColor: "#165873",
            hoverBackgroundColor: "#0f4155",
            borderColor: "transparent"
        }]
    };

    var config = {
        type: 'bar',

        // Chart Options
        options : chartOptions,

        data : chartData
    };

    // Create the chart
    var lineChart = new Chart(ctx, config);
});

//chart-2
$(window).on("load", function(){

    //Get the context of the Chart canvas element we want to select
    var ctx = $("#column-chart-2");

    // Chart Options
    var chartOptions = {
        // Elements options apply to all of the options unless overridden in a dataset
        // In this case, we are setting the border of each bar to be 2px wide and green
        elements: {
            rectangle: {
                borderWidth: 2,
                borderColor: 'rgb(0, 255, 0)',
                borderSkipped: 'bottom'
            }
        },
        responsive: true,
        maintainAspectRatio: false,
        responsiveAnimationDuration:500,
        
        scales: {
            xAxes: [{
                display: true,
                gridLines: {
                    color: "#f3f3f3",
                    drawTicks: false,
                },
                scaleLabel: {
                    display: true,
                }
            }],
            yAxes: [{
                display: true,
                gridLines: {
                    color: "#f3f3f3",
                    drawTicks: false,
                },
                scaleLabel: {
                    display: true,
                }
            }]
        }
    };

    // Chart Data 2
    var chartData2 = {
        labels: ["三芝區", "石門區", "金山區", "萬里區", "基隆市"],
        datasets: [{
            label: "淨攤",
            data: [23,25,21,24,20],
            backgroundColor: " #88F2F2",
            hoverBackgroundColor: "#77d9d9",
            borderColor: "transparent"
        }, {
            label: "淨山",
            data: [22,27,28,25,26],
            backgroundColor: "#0AA696",
            hoverBackgroundColor: "#05877a",
            borderColor: "transparent"
        },{
            label: "淨路",
            data: [25,24,23,26,23],
            backgroundColor: "#165873",
            hoverBackgroundColor: "#0f4155",
            borderColor: "transparent"
        }]
    };

    var config = {
        type: 'bar',

        // Chart Options
        options : chartOptions,

        data : chartData2
    };

    // Create the chart
    var lineChart = new Chart(ctx, config);
});

//chart-3
$(window).on("load", function(){

    //Get the context of the Chart canvas element we want to select
    var ctx = $("#column-chart-3");

    // Chart Options
    var chartOptions = {
        // Elements options apply to all of the options unless overridden in a dataset
        // In this case, we are setting the border of each bar to be 2px wide and green
        elements: {
            rectangle: {
                borderWidth: 2,
                borderColor: 'rgb(0, 255, 0)',
                borderSkipped: 'bottom'
            }
        },
        responsive: true,
        maintainAspectRatio: false,
        responsiveAnimationDuration:500,
        
        scales: {
            xAxes: [{
                display: true,
                gridLines: {
                    color: "#f3f3f3",
                    drawTicks: false,
                },
                scaleLabel: {
                    display: true,
                }
            }],
            yAxes: [{
                display: true,
                gridLines: {
                    color: "#f3f3f3",
                    drawTicks: false,
                },
                scaleLabel: {
                    display: true,
                }
            }]
        }
    };

    // Chart Data 3
    var chartData3 = {
        labels: ["三芝區", "石門區", "金山區", "萬里區", "基隆市"],
        datasets: [{
            label: "淨攤",
            data: [23,25,21,24,20],
            backgroundColor: " #88F2F2",
            hoverBackgroundColor: "#77d9d9",
            borderColor: "transparent"
        }, {
            label: "淨山",
            data: [22,27,28,25,26],
            backgroundColor: "#0AA696",
            hoverBackgroundColor: "#05877a",
            borderColor: "transparent"
        },{
            label: "淨路",
            data: [25,24,23,26,23],
            backgroundColor: "#165873",
            hoverBackgroundColor: "#0f4155",
            borderColor: "transparent"
        }]
    };

    var config = {
        type: 'bar',

        // Chart Options
        options : chartOptions,

        data : chartData3
    };

    // Create the chart
    var lineChart = new Chart(ctx, config);
});