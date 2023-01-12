const path = require('path');

module.exports = {
    entry: './wwwroot/js/index.js',
    output: {
        path: path.resolve(__dirname, "wwwroot/dist"),
    },
};