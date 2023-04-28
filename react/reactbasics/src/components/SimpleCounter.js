import React from "react";

class SimpleCounter extends React.Component{

    constructor(props){
        super(props)
        this.state={counter:0}
    }
    

    Increment (){
       // this.setState({color: "blue"});
        this.setState({counter:2})
    }
    Decrement (){
        this.setState({counter:3})
    }


    render(){
        return(
        <div>
            <h1> Simple Counter</h1>
            <h1> Counter {this.state.counter}</h1>
            <button onClick={this.Increment}>+</button>
            <button onClick={this.Decrement}>-</button>
        </div>
    )}
}

export default SimpleCounter