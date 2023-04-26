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
       */}
       <DemoForm/>
       
      
    </div>
  );
}

export default App;
