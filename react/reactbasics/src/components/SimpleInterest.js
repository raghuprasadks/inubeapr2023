import React,{useState} from 'react'

const SimpleInterest=()=>{

    const [principal,setPrincipal]=useState()
    const [roi,setRoi]=useState()
    const [time,setTime]=useState()
    const [si,setSi]=useState()

    const calculateSI=()=>{

        const interest = (parseFloat(principal)*parseFloat(roi)*parseFloat(roi))/100
        setSi(interest)

    }
    
    


    return(

        <div>
            <input value={principal} onChange={(e)=>setPrincipal(e.target.value)} placeholder='Enter Principal Amount'></input>
            <input value={roi} onChange={(e)=>setRoi(e.target.value)} placeholder='Enter Rate Of Interest'></input>
            <input value={time} onChange={(e)=>setTime(e.target.value)} placeholder='Enter Time in years'></input>
            <button onClick={calculateSI}>Calculate</button>
            <h1>Simple Interest is {si}</h1>
        </div>
    )
}

export default SimpleInterest