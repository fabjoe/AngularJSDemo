var app = angular.module("myApp", ['dx']);
app.controller("myCtrl", function ($scope, $http) {
    $scope.GetAllData = (function () {
        $http({
            method: "get",
            url: "/Employee/Get_AllEmployee"
        }).then(function (response) {
            $scope.employees = response.data;
            }, function (error) {
                console.log(error);
                alert("Error");
            })
    })
})
app.controller("playersCtrl", function playersCtrl($scope, $http) {
    
                $scope.dataGridOptions = {
                    dataSource: "/Players/GetAllPlayers"
    }
                $scope.bomber = 10;
})