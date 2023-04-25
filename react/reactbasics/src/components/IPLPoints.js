import React from "react";

const IPLPoints=()=>{

    const ipltable =[
        {
            id:1,
            name:'csk',
            matches:7,
            points:10
        },
        {
            id:2,
            name:'rr',
            matches:7,
            points:8
        }
    ]

    return(

        <div>
            <h1>Total Number of teams : {ipltable.length}</h1>
            <table>

                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Matches</th>
                    <th>Points</th>
                </tr>
                {ipltable.map((ipl)=><tr key={ipl.id}>
                    <td>{ipl.id}</td>
                    <td>{ipl.name}</td>
                    <td>{ipl.matches}</td>
                    <td>{ipl.points}</td>
                </tr>)}
            </table>
        </div>
    )
}
export default IPLPoints