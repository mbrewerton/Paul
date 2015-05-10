'use strict';

angular.module('paul')
    .factory('filmFactory', [
        '$resource', function ($resource) {
            return $resource("api/Search", {}, {
                getFilms: {
                    method: "GET",
                    url: "api/Film/GetFilms",
                    isArray: true
                },
                search: {
                    method: "GET",
                    url: "api/Film/Search",
                    isArray: true
                },
                saveFilm: {
                    method: "POST",
                    url: "api/Film/SaveFilm"
                }
            });
        }
    ]);