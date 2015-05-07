'use strict';

angular.module('paul')
    .factory('searchFactory', [
        '$resource', function ($resource) {
            return $resource("api/Search", {}, {
                search: {
                    method: "GET",
                    url: "api/Search/Search"
                }
            });
        }
    ]);