import { useState, useEffect } from "react";
import { Product } from "../../app/models/product";
import ProductList from "./productList";

export default function Catalog() {
    const [products, setProducts] = useState<Product[]>([]);

  useEffect(() => {
    fetch('http://localhost:5080/api/products')
      .then(response => response.json())
      .then(data => setProducts(data))
  }, [])

    return (
        <>
        <ProductList products={products}/>
        </>
    ) 
} 