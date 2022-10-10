import React from "react"
import Input from "./Input"
import { useNavigate } from "react-router-dom"

function Login() {
  const navigate = useNavigate()

  function navigateToHome() {
    navigate("/home")
  }
  return (
    <div className="container">
      <h1>Hello</h1>
      <p>Please log-in</p>
      <form className="form">
        <Input type="text" placeholder="Username" />
        <Input type="password" placeholder="Password" />
        <button onClick={navigateToHome}>Login</button>
      </form>
    </div>
  )
}

export default Login
