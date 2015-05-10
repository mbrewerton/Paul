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
                
                $scope.editing = !$scope.editing;

                if (film) {
                    $scope.filmsModel = film;
                    console.log('>> film : ', film);
                    console.log('>> filmsModel : ', $scope.filmsModel);
                } else {
                    $scope.filmsModel = {
                        Id: "",
                        FilmName: "",
                        ReleaseDate: "",
                        Genre: "",
                        ImdbRating: "",
                        MyRating: "",
                        Synopsis: "",
                        Watched: false  
                    };
                }
            };

            $scope.saveFilm = function (film) {
                $scope.isSaving = true;
                filmFactory.saveFilm($scope.filmsModel).$promise.then(
                    function () {
                        toastr.success("Film saved successfully!");
                        $scope.getFilms();
                        $scope.toggleEdit();
                    }, function () {
                        toastr.error("Error.");
                    }
                );

                $scope.isSaving = false;
            };

            $scope.test = function (data) {
                console.log('>> Hit ', data);
            };
        }]);