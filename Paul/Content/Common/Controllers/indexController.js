'use strict';

angular.module('paul')
    .controller('indexController', ['$scope', '$location', '_', 'filmFactory',
        function ($scope, $location, _, filmFactory) {
            $scope.searchData = {};
            $scope.searchData.term = '';
            $scope.searchData.watched = false;
            $scope.searchData.filter = 'name';
            $scope.loading = true;
            $scope.editing = false;
            $scope.filmToEdit = {};
            $scope.films = [];            

            $scope.getFilms = function () {
                $scope.loading = true;
                filmFactory.getFilms().$promise.then(
                                function (data) {
                                    $scope.films = data;
                                    $scope.loading = false;
                                    console.log('>> ', data);
                                }
                            );
            };

            $scope.getFilms();

            $scope.search = function () {
                $scope.loading = true;
                if ($scope.searchData.term === undefined || $scope.searchData.term === "") {
                    $scope.getFilms();
                    $scope.loading = false;
                } else {
                    filmFactory.search({ searchTerm: $scope.searchData.term }).$promise.then(
                        function (data) {
                            $scope.films = data;
                            $scope.loading = false;
                            console.log('>> ', data);
                        }
                    );
                }
            };

            $scope.toggleEdit = function (film) {
                if (film) {
                    $scope.editing = true;
                    $scope.filmToEdit = film;
                } else {
                    $scope.editing = false;
                    $scope.filmToEdit = {};
                }
            };

            $scope.saveFilm = function (film) {
                $scope.test(film);
            };

            $scope.addEmptyFilm = function () {
                $scope.editing = true;
                $scope.filmsModel = [{
                    Id: "",
                    FilmName: "",
                    ReleaseDate: "",
                    Genre: "",
                    ImdbRating: "",
                    MyRating: "",
                    Synopsis: "",
                    Watched: false
                }];
            };

            $scope.test = function (data) {
                console.log('>> Hit ', data);
            };
        }]);