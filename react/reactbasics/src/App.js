import logo from './logo.svg';
import './App.css';
import Header from './Header';
import Content from './Content';
import Footer from './Footer';
import Employee from './components/Employee';
import IPLPoints from './components/IPLPoints';

function App() {
  return (
    <div>
      <h1>Welcome to React</h1>
      {/**
      <Header></Header>
      <Employee></Employee>
      <Footer></Footer> 
       */}
      <IPLPoints></IPLPoints> 
    </div>
  );
}

export default App;
