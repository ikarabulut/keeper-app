import React, { useState } from "react"
// import Input from "./Input"
import { useNavigate } from "react-router-dom"

function Login() {
  const navigate = useNavigate()

  const validCredentials = {
    username: "test",
    password: "password",
  }

  const [username, setUsername] = useState("")
  const [password, setPassword] = useState("")

  const [loginError, setLoginError] = useState(false)

  function handleUsernameChange(event) {
    setUsername(event.target.value)
  }

  function handlePasswordChange(event) {
    setPassword(event.target.value)
  }

  function navigateToHome(event) {
    if (
      username === validCredentials.username &&
      password === validCredentials.password
    ) {
      navigate("/home")
    } else {
      setLoginError(true)
      setUsername("")
      setPassword("")
      event.preventDefault()
    }
  }
  return (
    <div className="container">
      <h1>Hello</h1>
      <p>Please log-in</p>
      <form className="form">
        <input
          onChange={handleUsernameChange}
          type="text"
          placeholder="Username"
          value={username}
        />
        <input
          onChange={handlePasswordChange}
          type="password"
          placeholder="Password"
          value={password}
        />
        <button onClick={navigateToHome}>Login</button>
      </form>
      {loginError && (
        <h2 id="loginError">Incorrect Credentials, Please try again</h2>
      )}
    </div>
  )
}

export default Login
