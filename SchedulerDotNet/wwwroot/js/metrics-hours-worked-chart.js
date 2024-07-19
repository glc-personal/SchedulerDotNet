document.addEventListener('DOMContentLoaded', function () {
    var ctx = document.getElementById('metricsHoursWorkedChart').getContext('2d');
    var metricsChart = new Chart(ctx, {
        type: 'line',
        data: {
            labels: ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday'],
            datasets: [{
                label: 'Metric Values',
                data: [68, 45, 56, 12, 32, 42, 40],
                backgroundColor: 'rgba(75, 192, 192, 0.2)',
                borderColor: 'rgba(75, 192, 192, 1)',
                borderWidth: 2,
                fill: true,
                pointBackgroundColor: '#fff',
                pointBorderColor: 'rgba(75, 192, 192, 1)',
                pointBorderWidth: 2,
                pointRadius: 5,
            }]
        },
        options: {
            scales: {
                y: {
                    beginAtZero: true
                }
            },
            plugins: {
                legend: {
                    display: false
                },
                datalabels: {
                    align: 'top',
                    anchor: 'end',
                    backgroundColor: function (context) {
                        return context.dataset.borderColor;
                    },
                    borderRadius: 4,
                    color: 'white',
                    font: {
                        weight: 'bold'
                    },
                    formatter: function (value, context) {
                        var index = context.dataIndex;
                        var label = context.chart.data.labels[index];
                        return label + '\n' + value;
                    }
                }
            }
        }
    });
});
