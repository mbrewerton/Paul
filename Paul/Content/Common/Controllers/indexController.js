'use strict';

angular.module('paul')
    .controller('indexController', ['$scope', '$location', '_', 'searchFactory',
        function ($scope, $location, _, searchFactory) {
            $scope.searchData = {};

            $scope.search = function () {
                searchFactory.search().$promise.then(
                    function (data) {
                        $scope.searchData.term = data;
                    }
                );
            };
        }]);