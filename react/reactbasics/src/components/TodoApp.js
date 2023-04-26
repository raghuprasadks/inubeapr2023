import React, { useState } from "react";


const TodoApp = () => {
    document.title = 'Simple Todo List Example';
  const [todoItem, setTodoItem] = useState("");
/**
  const [todoList, setTodoList] = useState([
    { id: 1, text: "Learn about React" },
    { id: 2, text: "Meet friend for lunch" },
    { id: 3, text: "Build really cool todo app" }
  ]);

   */

  const [todoList, setTodoList] = useState([]);

  const generateId = () => {
     const highestId = Math.max.apply(Math, todoList.map(function (element) {
            return element.id;
        }));
        let newId = 1; // default in case the array is empty

        if (highestId > 0) {
            // generate a new ID based off of the highest existing element ID 
            newId = (highestId + 1);
        }
        return newId;
  };

  function createNewToDoItem() {
    if (todoItem !== '') {
      const item = { id: generateId(), text: todoItem };
      const tempArray = [...todoList, item];
      setTodoList(tempArray);
    }
    setTodoItem('');
  }

  function handleAdd(e) {
    e.preventDefault();
    createNewToDoItem();
  }

  const handleKeyPress = e => {
    if (e.key === 'Enter') {
      createNewToDoItem();
    }
  };

  const deleteItem = id => {
    setTodoList(todoList.filter(item => item.id !== id));
  };

  const display = todoList.map(item => (
    <li key={item.id} onClick={() => deleteItem(item.id)}>
      {item.text}
    </li>
  ));

    return (
        <div className="container mt-5 col-8">
      <h3>Simple Todo List - {display.length}</h3>
      <div className="input-group">
        <input
          type="text"
          name="todoItem"
          value={todoItem}
          onChange={e => {
            setTodoItem(e.currentTarget.value);
          }}
          onKeyPress={handleKeyPress}
          className="form-control"
        />

        <div className="input-group-append">
          <button type="button" onClick={handleAdd} className="btn btn-primary">
            Add Todo
          </button>
        </div>
      </div>
      <ul>{display}</ul>
    </div>
  );
    
}

export default TodoApp
