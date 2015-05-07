'use strict';

angular.module('paul')
    .controller('pageController', ['$rootScope', '$scope', '$location',
        function ($rootScope, $scope, $location) {
            $scope.templateUrl = {
                index: "Content/Common/Templates/index.html",
                edit: "Content/Common/Templates/edit.html"
            };

            console.log($scope.templateUrl);

            $rootScope.showIndex = true;
            $rootScope.showEdit = false;

            $rootScope.toggleIndex = function () {
                $rootScope.showIndex = true;
                $rootScope.showEdit = false;
            };

            $rootScope.showEdit = false;
            $rootScope.toggleEdit = function () {
                $rootScope.showIndex = false;
                $rootScope.showEdit = true;
            };
        }]);