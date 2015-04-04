var adsApp = angular.module('adsApp', ['ngRoute']);

adsApp.config(function ($routeProvider, $locationProvider) {
    //$locationProvider.html5Mode(true);

    $routeProvider
        .when('/register',
        {
            templateUrl: 'partials/register.html',
            controller: ''
        })
        .when('/login',
        {
            templateUrl: 'partials/login.html',
            controller: ''
        })
        .when('/home',
        {
            templateUrl: 'partials/home.html',
            controller: ''
        })
        .otherwise(
        {
            redirectTo: '/login'
        });
});
