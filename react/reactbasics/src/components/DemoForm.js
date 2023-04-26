import React,{useState} from "react";

const DemoForm = ()=>{
    const [name,setName]=useState('use state demo')
    const handleChange=(e)=>{
        setName(e.target.value)
    }

    return(
        <form>
            <input value={name} onChange={handleChange}>
            </input>
            <h1>Your name is {name}</h1>
        </form>
    )
}

export default DemoForm