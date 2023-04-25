import React from "react";

const Customer=(props)=>{

    const customerlist = props.custlist
    return(
        <div>
        <h1>Customers List</h1>
        <table>
            <tr>
                <th>Id</th>
                <th>Name</th>
                <th>Location</th>
            </tr>

            {customerlist.map((customer)=>
            <tr>
                <td>{customer.id}</td>
                <td>{customer.name}</td>
                <td>{customer.location}</td>
            </tr>
            )}
        </table>

        </div>
    )
}

export default Customer