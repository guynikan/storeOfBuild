var gulp = require('gulp');
var concat = require('gulp-concat');
var cssmin = require('gulp-cssmin');
var uncss = require('gulp-uncss');
var browserSync = require('browser-sync').create();


function style(){

    return gulp.src([
        './style/site.css',
        './node_modules/bootstrap/dist/css/bootstrap.css',
    ])
    .pipe(concat('site.min.css'))
    .pipe(cssmin())
    .pipe(uncss({html: ['Views/**/*.cshtml']}))
    .pipe(gulp.dest('wwwroot/css'))
    .pipe(browserSync.stream());
};

function js(){

    return gulp.src([
        './node_modules/jquery/dist/jquery.min.js',
        './node_modules/bootstrap/dist/js/bootstrap.min.js',
        './node_modules/jquery-validation/dist/jquery.validate.min.js',
        './node_modules/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.js',
        './js/site.js',
    ])
    .pipe(gulp.dest('wwwroot/js/'))
    .pipe(browserSync.stream());
};

function serve(){

    browserSync.init({ 
        proxy: 'localhost:5000'
         
    });

    gulp.watch('./style/*.css', style);
    gulp.watch('./js/*.js', js).on('change', browserSync.reload);
    
};

exports.style = style;
exports.serve = serve;
exports.js = js;





