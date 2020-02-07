'use strict'

const path = require('path')

const HtmlWebpackPlugin = require('html-webpack-plugin')
const ExtractTextPlugin = require('extract-text-webpack-plugin')
const UglifyJSWebpackPlugin = require('uglifyjs-webpack-plugin')

module.exports = {
  entry: './scripts/index.js',
  output: {
    path: path.resolve(__dirname, 'build-production'),
    filename: 'js/[name]-[hash].min.js'
  },
  module: {
    rules: [
      {
        test: /\.jsx?$/,
        loader: 'babel-loader',
        options: {
          presets: ['es2015']
        }
      },
      {
        test: /\.scss$/,
        loader: ExtractTextPlugin.extract({
          fallback: 'style-loader',
          use: ['css-loader', 'sass-loader']
        })
      },
      {
        test: /\.(png|jpe?g)$/,
        loader: 'file-loader',
        options: {
          outputPath: 'images/',
          publicPath: '../'
        }
      }
    ]
  },
  plugins: [
    new ExtractTextPlugin('css/style-[contenthash].css'),
    new HtmlWebpackPlugin({
      filename: 'index.html',
      template: 'index.html'
    }),
    new UglifyJSWebpackPlugin()
  ]
}
