import React,{useState,useEffect} from "react";

const Product=()=>{

    const [products,setProducts]=useState([])

    const url="https://localhost:44343/api/products"

    useEffect(()=>{
        fetch(url)
        .then(response=>response.json())
        .then(json=>setProducts(json))
    },[]        
    )

    const productdata = products.map((product)=>
    <tr key={product.Id}>

        <td>{product.name}</td>
        <td>{product.desc}</td>
        <td>{product.supplier}</td>
        <td>{product.price}</td>       
    </tr>
    )



    return(
        <>
        
            <div>
                <h1>Product Master</h1>
                <table>
                    <tr>
                    <th>Name</th>
                    <th>Description</th>
                    <th>Supplier</th>
                    <th>Price</th>
                    </tr>
                    {productdata}
                </table>
            </div>
            </>
    )
}

export default Product