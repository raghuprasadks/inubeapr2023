import React from "react";

const Employee = ()=>{
    const employee ={
        code:1,
        name:'Ravi',
        dept:'IT',
        desg:'Programmer',
        sal:30000
    }
    return(
        <div>
            <h1>Employee</h1>
            <p>Code : {employee.code}</p>
            <p>Name : {employee.name}</p>
        </div>
    )
}

export default Employee