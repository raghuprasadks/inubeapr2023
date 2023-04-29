import React,{useState} from "react";
import Component2 from "./Component2";

const Component1=()=>{
    const [user, setUser] = useState("Jesse Hall");
    return (
        <>
      <h1>{`Hello component 1 ${user}!`}</h1>
      <Component2 user={user} />
        </>
    )
}

export default Component1