import logo from './logo.svg';
import './App.css';
import Header from './Header';
import Content from './Content';
import Footer from './Footer';
import Employee from './components/Employee';
import IPLPoints from './components/IPLPoints';
import Customer from './components/Customer';
import Users from './components/Users';
import DemoForm from './components/DemoForm';
import SimpleInterest from './components/SimpleInterest';
import TodoApp from './components/TodoApp';
import EmployeeMaster from './components/EmployeeMaster';
import { FetchApiDemo } from './components/FetchAPIDemo';
import PostAPI from './components/PostAPI';
import Car from './components/Car';
import SimpleCounter from './components/SimpleCounter';

function App() {

  const customers=[
    {
      id:1,
      name:'raju',
      location:'bengaluru'
    },
    {
      id:2,
      name:'gagana',
      location:'mysuru'
    },
    {
      id:3,
      name:'reddy',
      location:'hubli'
    }


  ]

  return (
    <div>
      <h1>Welcome to React</h1>
      {/**
      <Header></Header>
      <Employee></Employee>
      <Footer></Footer> 
      <IPLPoints></IPLPoints> 
      <img src='logo.jpg'>
      <Customer custlist={customers}></Customer>
      <Users></Users>
       <DemoForm/>
         <SimpleInterest/>
       <TodoApp/>
        <EmployeeMaster></EmployeeMaster>
         <FetchApiDemo></FetchApiDemo>
         <PostAPI></PostAPI>
         <Car/>
      */}
      
      <SimpleCounter/>
       
    

     

      
      
      
    </div>
  );
}

export default App;
