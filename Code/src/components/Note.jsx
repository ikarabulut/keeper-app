import React from "react"

function Note(props) {
  function handleClick() {
    props.onDelete(props.id)
  }
  return (
    <div name={props.title} className="note">
      <h1>{props.title}</h1>
      <p>{props.content}</p>
      <button name="deleteNote" onClick={handleClick}>
        DELETE
      </button>
    </div>
  )
}

export default Note
