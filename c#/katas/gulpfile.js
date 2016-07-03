"use strict";

var gulp = require('gulp'),
    shell = require('gulp-shell');

gulp.task('default', ['test', 'watch']);

gulp.task('watch', function() {
    gulp.watch(['**/*.cs'], ['test']);
});

function getArgOrDefault(key, defaultVal){
    for (let arg of process.argv) {
      if (!arg.startsWith('--') || !arg.includes('=')) continue;
      let argKey = arg.substring(2, arg.indexOf('='));
      let argValue = arg.split('=')[1];
      if (argKey === key) {
        return argValue;
      }
    }
    return defaultVal;
};

gulp.task('test', shell.task(["dotnet test"])
).on('error', function() {
    this.emit('end');
});
