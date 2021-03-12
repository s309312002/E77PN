/*=========================================================================================
    File Name: pie.js
    Description: Chartjs pie chart
    ----------------------------------------------------------------------------------------
    Item Name: Chameleon Admin - Modern Bootstrap 4 WebApp & Dashboard HTML Template + UI Kit
    Version: 1.0
    Author: ThemeSelection
    Author URL: https://themeselection.com/
==========================================================================================*/

// Pie chart
$(window).on("load", function () {
    var ctx = document.getElementById("pie-chart").getContext("2d");
    //Get the context of the Chart canvas element we want to select
    var ctx = $("#pie-chart");

    // Chart Options
    var chartOptions = {
        responsive: true,
        maintainAspectRatio: false,
        responsiveAnimationDuration: 500,
    };

    // Chart Data
    var chartData = {
        labels: ["北部地區", "中部地區", "南部地區", "東部地區", "離島地區"],
        datasets: [{
            label: "My First dataset",
            data: [40, 25, 35, 30, 20],
            backgroundColor: ['#666EE8', '#28D094', '#FF4961', '#1E9FF2', '#FF9149'],
        }]
    };
    console.log(chartData);
    var config = {
        type: 'pie',

        // Chart Options
        options: chartOptions,

        data: chartData
    };

    // Create the chart
    var pieSimpleChart = new Chart(ctx, config);
});

// Pie chart 2
$(window).on("load", function () {

    //Get the context of the Chart canvas element we want to select
    var ctx = $("#pie-chart-2");

    // Chart Options
    var chartOptions = {
        responsive: true,
        maintainAspectRatio: false,
        responsiveAnimationDuration: 500,
    };

    // Chart Data
    var chartData2 = {
       //labels: ["北部地區", "中部地區", "南部地區", "東部地區", "離島地區"],
        labels: ["北部地區", "中部地區", "南部地區", "東部地區", "離島地區"],
        datasets: [{
            label: "My First dataset",
            data: [40, 25, 35, 30, 20],
            backgroundColor: ['#666EE8', '#28D094', '#FF4961', '#1E9FF2', '#FF9149'],
        }]
    };

    var config = {
        type: 'pie',

        // Chart Options
        options: chartOptions,

        data: chartData2
    };

    // Create the chart
    var pieSimpleChart = new Chart(ctx, config);
});

// Pie chart 3
$(window).on("load", function () {

    //Get the context of the Chart canvas element we want to select
    var ctx = $("#pie-chart-3");

    // Chart Options
    var chartOptions = {
        responsive: true,
        maintainAspectRatio: false,
        responsiveAnimationDuration: 500,
    };

    // Chart Data
    var chartData3 = {
        labels: ["北部地區", "中部地區", "南部地區", "東部地區", "離島地區"],
        datasets: [{
            label: "My First dataset",
            data: [40, 25, 35, 30, 20],
            backgroundColor: ['#666EE8', '#28D094', '#FF4961', '#1E9FF2', '#FF9149'],
        }]
    };

    var config = {
        type: 'pie',

        // Chart Options
        options: chartOptions,

        data: chartData3
    };

    // Create the chart
    var pieSimpleChart = new Chart(ctx, config);
});

// Pie chart 4
$(window).on("load", function () {

    //Get the context of the Chart canvas element we want to select
    var ctx = $("#pie-chart-4");

    // Chart Options
    var chartOptions = {
        responsive: true,
        maintainAspectRatio: false,
        responsiveAnimationDuration: 500,
    };

    // Chart Data
    var chartData4 = {
        labels: ["北部地區", "中部地區", "南部地區", "東部地區", "離島地區"],
        datasets: [{
            label: "My First dataset",
            data: [40, 25, 35, 30, 20],
            backgroundColor: ['#666EE8', '#28D094', '#FF4961', '#1E9FF2', '#FF9149'],
        }]
    };

    var config = {
        type: 'pie',

        // Chart Options
        options: chartOptions,

        data: chartData4
    };

    // Create the chart
    var pieSimpleChart = new Chart(ctx, config);
});

// Pie chart 5
$(window).on("load", function () {

    //Get the context of the Chart canvas element we want to select
    var ctx = $("#pie-chart-5");

    // Chart Options
    var chartOptions = {
        responsive: true,
        maintainAspectRatio: false,
        responsiveAnimationDuration: 500,
    };

    // Chart Data
    var chartData5 = {
        labels: ["北部地區", "中部地區", "南部地區", "東部地區", "離島地區"],
        datasets: [{
            label: "My First dataset",
            data: [40, 25, 35, 30, 20],
            backgroundColor: ['#666EE8', '#28D094', '#FF4961', '#1E9FF2', '#FF9149'],
        }]
    };

    var config = {
        type: 'pie',

        // Chart Options
        options: chartOptions,

        data: chartData5
    };

    // Create the chart
    var pieSimpleChart = new Chart(ctx, config);
});

// Pie chart 6
$(window).on("load", function () {

    //Get the context of the Chart canvas element we want to select
    var ctx = $("#pie-chart-6");

    // Chart Options
    var chartOptions = {
        responsive: true,
        maintainAspectRatio: false,
        responsiveAnimationDuration: 500,
    };

    // Chart Data
    var chartData6 = {
        labels: ["北部地區", "中部地區", "南部地區", "東部地區", "離島地區"],
        datasets: [{
            label: "My First dataset",
            data: [40, 25, 35, 30, 20],
            backgroundColor: ['#666EE8', '#28D094', '#FF4961', '#1E9FF2', '#FF9149'],
        }]
    };

    var config = {
        type: 'pie',

        // Chart Options
        options: chartOptions,

        data: chartData6
    };

    // Create the chart
    var pieSimpleChart = new Chart(ctx, config);
});