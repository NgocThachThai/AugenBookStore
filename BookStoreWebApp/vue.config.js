module.exports = {
  devServer: {
    disableHostCheck: true,
    proxy: {
      '^/api': {
        target: process.env.API_ENDPOINT,
        changeOrigin: true,
        ws: true,
        pathRewrite: { '^/api': '/api' }
      },
      '^/google-api': {
        target: process.env.GOOGLE_API_ENDPOINT,
        ws: true,
        changeOrigin: true,
        pathRewrite: { '^/google-api': '/' }
      }
    },
  },
  transpileDependencies: [
    "vuetify"
  ]
}