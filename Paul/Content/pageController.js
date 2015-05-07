'use strict';

angular.module('paul')
    .controller('pageController', ['$rootScope', '$scope', '$location',
        function ($rootScope, $scope, $location) {
            $scope.templateUrl = {
                index: "Content/Common/Templates/index.html"
            };

            console.log($scope.templateUrl);

            $rootScope.showIndex = true;
            $rootScope.toggleIndex = function () {
                $rootscope.index = !$rootscope.index;
            };


        }]);