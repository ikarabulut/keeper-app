import React from "react"
import HomePage from "./HomePage"
import Login from "./Login"

function App() {
  let isLoggedIn = true

  return isLoggedIn ? <HomePage /> : <Login />
}

export default App
