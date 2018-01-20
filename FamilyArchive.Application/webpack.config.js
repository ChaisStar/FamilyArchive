var path = require('path');
var webpack = require('webpack');
var UglifyJSPlugin = require('uglifyjs-webpack-plugin');
var HtmlWebpackPlugin = require("html-webpack-plugin");
module.exports = {
    entry: {
        'polyfills': './src/polyfills.ts',
        'app': './src/main.ts'
    },
    output: {
        path: path.resolve(__dirname, './wwwroot'),
        publicPath: '',
        filename: "[name].js"
    },
    resolve: {
        extensions: ['.ts', '.js']
    },
    module: {
        rules: [{
            test: /\.ts$/,
            use: [{
                    loader: 'awesome-typescript-loader',
                    options: { configFileName: path.resolve(__dirname, 'tsconfig.json') }
                },
                'angular2-template-loader'
            ]
        }, {
            test: /\.html$/,
            loader: 'html-loader'
        }, {
            test: /\.css$/,
            include: path.resolve(__dirname, 'src/app'),
            loader: 'raw-loader'
        }]
    },
    plugins: [
        new webpack.ContextReplacementPlugin(
            /angular(\\|\/)core/,
            path.resolve(__dirname, 'src'), {}
        ),
        new webpack.optimize.CommonsChunkPlugin({
            name: ['app', 'polyfills']
        }),
        new UglifyJSPlugin(),
        new HtmlWebpackPlugin({
            hash: true,
            inject: false,
            template: require("html-webpack-template"),
            bodyHtmlSnippet: "<my-app>Loading...</my-app>",
            title: "FamilyArchive",
            links: [
                "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/css/bootstrap.min.css"
            ]
        })
    ]
}