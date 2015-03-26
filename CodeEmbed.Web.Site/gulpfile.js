var gulp = require('gulp');
var concat = require('gulp-concat');
var sourcemaps = require('gulp-sourcemaps');
var uglify = require('gulp-uglify');
var prefix = require('gulp-autoprefixer');
var minifyCss = require('gulp-minify-css');

gulp.task('scripts', ['clean:scripts'], function() {
    
    return gulp.src([
            'bower_components/jquery/dist/jquery.js',
            
            'bower_components/bootstrap/dist/js/bootstrap.js',
            
            'lib/syntaxhighlighter/scripts/shCore.js',
            'lib/syntaxhighlighter/scripts/shBrushCSharp.js',
            'lib/syntaxhighlighter/scripts/shBrushJScript.js',
            
            'lib/lightview/js/lightview/lightview.js',
            'lib/lightview/js/spinners/spinners.min.js',
            
            'scripts/jQuery.SyntaxHighlighter.js'
        ])
        .pipe(sourcemaps.init())
        .pipe(concat('scripts.js'))
        .pipe(uglify())
        .pipe(sourcemaps.write('.'))
        .pipe(gulp.dest('scripts'));
        
});

gulp.task('styles', ['clean:styles'], function() {
    
    return gulp.src([
            'bower_components/bootstrap/dist/css/bootstrap.css',
            
            'lib/syntaxhighlighter/styles/shCore.css',
            'lib/syntaxhighlighter/styles/shThemeEclipse.css',
            
            'lib/lightview/css/lightview/lightview.css',
            
            'css/site.css'
        ])
        .pipe(sourcemaps.init())
        .pipe(prefix())
        .pipe(concat('styles.css'))
        .pipe(minifyCss())
        .pipe(sourcemaps.write('.'))
        .pipe(gulp.dest('css'));
        
});

gulp.task('fonts', ['clean:fonts'], function() {
    
    return gulp.src(
            'bower_components/bootstrap/dist/fonts/*'
        )
        .pipe(gulp.dest('fonts'));
        
});

gulp.task('lightview', ['clean:lightview'], function() {

    return gulp.src(
            'lib/lightview/css/lightview/skins/**/*'
        )
        .pipe(gulp.dest('css/skins'));

});

gulp.task('default', ['scripts', 'styles', 'fonts', 'lightview']);
