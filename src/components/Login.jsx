import React from "react"
import Input from "./Input"

function Login() {
  return (
    <div className="container">
      <h1>Hello</h1>
      <p>Please log-in</p>
      <form className="form">
        <Input type="text" placeholder="Username" />
        <Input type="password" placeholder="Password" />
        <button>Login</button>
      </form>
    </div>
  )
}

export default Login
