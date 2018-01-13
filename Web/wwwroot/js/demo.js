type = ['', 'info', 'success', 'warning', 'danger'];


demo = {
    initPickColor: function() {
        $('.pick-class-label').click(function() {
            var new_class = $(this).attr('new-class');
            var old_class = $('#display-buttons').attr('data-class');
            var display_div = $('#display-buttons');
            if (display_div.length) {
                var display_buttons = display_div.find('.btn');
                display_buttons.removeClass(old_class);
                display_buttons.addClass(new_class);
                display_div.attr('data-class', new_class);
            }
        });
    },

    initDocumentationCharts: function() {
        /* ----------==========     Daily Sales Chart initialization For Documentation    ==========---------- */


        $.getJSON('/FtsVehicle/EnCokMesafeKatedenAraclar', function (data) {
            var tempLabels = []

            for (var i = 0; i < data.length; i++) {
                tempLabels.push(data[i].VehicleId)
            }

            var tempseries = []

            for (var i = 0; i < data.length; i++) {
                tempseries.push(data[i].TotalDistance)
            }

            dataDailySalesChart = {
                labels: tempLabels,
                series: [
                    tempseries
                ]
            };
        })

        

        optionsDailySalesChart = {
            lineSmooth: Chartist.Interpolation.cardinal({
                tension: 0
            }),
            low: 0,
            high: 50, // creative tim: we recommend you to set the high sa the biggest value + something for a better look
            chartPadding: {
                top: 0,
                right: 0,
                bottom: 0,
                left: 0
            },
        }

        var dailySalesChart = new Chartist.Line('#dailySalesChart', dataDailySalesChart, optionsDailySalesChart);

        md.startAnimationForLineChart(dailySalesChart);
    },

    initDashboardPageCharts: function () {

        /* ----------==========     Daily Sales Chart initialization    ==========---------- */

        $.getJSON('/FtsVehicle/EnCokMesafeKatedenAraclar', function (data) {
            var tempLabels = []

            for (var i = 0; i < data.length; i++) {
                tempLabels.push(data[i].VehicleId)
            }

            var tempseries = []

            for (var i = 0; i < data.length; i++) {
                tempseries.push(data[i].TotalDistance)
            }
            console.log(tempseries)
            dataDailySalesChart = {
                labels: tempLabels,
                series: [tempseries]
            };


            optionsDailySalesChart = {
                lineSmooth: Chartist.Interpolation.cardinal({
                    tension: 0
                }),
                low: 0,
                high: 1000, // creative tim: we recommend you to set the high sa the biggest value + something for a better look
                chartPadding: {
                    top: 0,
                    right: 0,
                    bottom: 0,
                    left: 0
                },
            }

            var dailySalesChart = new Chartist.Line('#dailySalesChart', dataDailySalesChart, optionsDailySalesChart);

            md.startAnimationForLineChart(dailySalesChart);
        })

        /* ----------==========     Emails Subscription Chart2 initialization    ==========---------- */
        $.getJSON('/FtsVehicle/EnCokMesafeKatedenOnAraclar', function (data) {
            var tempLabels = []

            for (var i = 0; i < data.length; i++) {
                tempLabels.push(data[i].VehicleId)
            }

            var tempseries = []

            for (var i = 0; i < data.length; i++) {
                tempseries.push(data[i].TotalDistance)
            }
            console.log(tempseries)
            var dataEmailsSubscriptionChart = {
                labels: tempLabels,
                series: [
                    tempseries

                ]
            };
            var optionsEmailsSubscriptionChart = {
                axisX: {
                    showGrid: false
                },
                low: 0,
                high: 3000,
                chartPadding: {
                    top: 0,
                    right: 5,
                    bottom: 0,
                    left: 0
                }
            };
            var responsiveOptions = [
                ['screen and (max-width: 640px)', {
                    seriesBarDistance: 5,
                    axisX: {
                        labelInterpolationFnc: function (value) {
                            return value[0];
                        }
                    }
                }]
            ];
            var YakitAlimChart = Chartist.Bar('#YakitAlimChart', dataEmailsSubscriptionChart, optionsEmailsSubscriptionChart, responsiveOptions);

            //start animation for the Emails Subscription Chart
            md.startAnimationForBarChart(YakitAlimChart);
        })

        /* ----------==========     Completed Tasks Chart initialization    ==========---------- */
        $.getJSON('/FtsVehicle/EnCokGorevAlanPersoneller', function (data) {
            var tempLabels = []

            for (var i = 0; i < data.length; i++) {
                tempLabels.push(data[i].Ad)
            }

            var tempseries = []

            for (var i = 0; i < data.length; i++) {
                tempseries.push(data[i].PersonId)
            }
            console.log(tempseries)
            console.log(tempLabels)

          
            dataCompletedTasksChart = {
                labels: tempLabels,
                series: [tempseries]
            };

            optionsCompletedTasksChart = {
                lineSmooth: Chartist.Interpolation.cardinal({
                    tension: 0
                }),
                low: 0,
                high: 1000, // creative tim: we recommend you to set the high sa the biggest value + something for a better look
                chartPadding: {
                    top: 0,
                    right: 0,
                    bottom: 0,
                    left: 0
                }
            }

            var completedTasksChart = new Chartist.Line('#completedTasksChart', dataCompletedTasksChart, optionsCompletedTasksChart);

            // start animation for the Completed Tasks Chart - Line Chart
            md.startAnimationForLineChart(completedTasksChart);


            /* ----------==========     Emails Subscription Chart initialization    ==========---------- */
            $.getJSON('/FtsVehicle/AraclarinToplamYakitTuketimi', function (data) {
                var tempLabels = []

                for (var i = 0; i < data.length; i++) {
                    tempLabels.push(data[i].VehicleId)
                }

                var tempseries = []

                for (var i = 0; i < data.length; i++) {
                    tempseries.push(data[i].TotalAmount)
                }
                console.log(tempseries)
                var dataEmailsSubscriptionChart = {
                    labels: tempLabels,
                    series: [
                        tempseries

                    ]
                };
                var optionsEmailsSubscriptionChart = {
                    axisX: {
                        showGrid: false
                    },
                    low: 0,
                    high: 3000,
                    chartPadding: {
                        top: 0,
                        right: 5,
                        bottom: 0,
                        left: 0
                    }
                };
                var responsiveOptions = [
                    ['screen and (max-width: 640px)', {
                        seriesBarDistance: 5,
                        axisX: {
                            labelInterpolationFnc: function (value) {
                                return value[0];
                            }
                        }
                    }]
                ];
                var emailsSubscriptionChart = Chartist.Bar('#emailsSubscriptionChart', dataEmailsSubscriptionChart, optionsEmailsSubscriptionChart, responsiveOptions);

                //start animation for the Emails Subscription Chart
                md.startAnimationForBarChart(emailsSubscriptionChart);
            })


        })
    },
          
    initGoogleMaps: function() {
        var myLatlng = new google.maps.LatLng(40.748817, -73.985428);
        var mapOptions = {
            zoom: 13,
            center: myLatlng,
            scrollwheel: false, //we disable de scroll over the map, it is a really annoing when you scroll through page
            styles: [{
                "featureType": "water",
                "stylers": [{
                    "saturation": 43
                }, {
                    "lightness": -11
                }, {
                    "hue": "#0088ff"
                }]
            }, {
                "featureType": "road",
                "elementType": "geometry.fill",
                "stylers": [{
                    "hue": "#ff0000"
                }, {
                    "saturation": -100
                }, {
                    "lightness": 99
                }]
            }, {
                "featureType": "road",
                "elementType": "geometry.stroke",
                "stylers": [{
                    "color": "#808080"
                }, {
                    "lightness": 54
                }]
            }, {
                "featureType": "landscape.man_made",
                "elementType": "geometry.fill",
                "stylers": [{
                    "color": "#ece2d9"
                }]
            }, {
                "featureType": "poi.park",
                "elementType": "geometry.fill",
                "stylers": [{
                    "color": "#ccdca1"
                }]
            }, {
                "featureType": "road",
                "elementType": "labels.text.fill",
                "stylers": [{
                    "color": "#767676"
                }]
            }, {
                "featureType": "road",
                "elementType": "labels.text.stroke",
                "stylers": [{
                    "color": "#ffffff"
                }]
            }, {
                "featureType": "poi",
                "stylers": [{
                    "visibility": "off"
                }]
            }, {
                "featureType": "landscape.natural",
                "elementType": "geometry.fill",
                "stylers": [{
                    "visibility": "on"
                }, {
                    "color": "#b8cb93"
                }]
            }, {
                "featureType": "poi.park",
                "stylers": [{
                    "visibility": "on"
                }]
            }, {
                "featureType": "poi.sports_complex",
                "stylers": [{
                    "visibility": "on"
                }]
            }, {
                "featureType": "poi.medical",
                "stylers": [{
                    "visibility": "on"
                }]
            }, {
                "featureType": "poi.business",
                "stylers": [{
                    "visibility": "simplified"
                }]
            }]

        }
        var map = new google.maps.Map(document.getElementById("map"), mapOptions);

        var marker = new google.maps.Marker({
            position: myLatlng,
            title: "Hello World!"
        });

        // To add the marker to the map, call setMap();
        marker.setMap(map);
    },

    showNotification: function(from, align) {
        color = Math.floor((Math.random() * 4) + 1);

        $.notify({
            icon: "notifications",
            message: "Welcome to <b>Material Dashboard</b> - a beautiful freebie for every web developer."

        }, {
            type: type[color],
            timer: 4000,
            placement: {
                from: from,
                align: align
            }
        });
    }



}