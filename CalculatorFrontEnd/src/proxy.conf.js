const PROXY_CONFIG = [
  {
    context: [
      "/api",
    ],
    target: "https://localhost:49153",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
