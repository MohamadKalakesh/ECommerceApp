import { useState, useEffect } from 'react'
import { Product } from '../../app/models/products'
import ProductList from './ProductList'

export default function Catalog() {
  const [products, setProducts] = useState<Product[]>([])

  useEffect(() => {
    fetch('http://localhost:5000/api/products')
      .then((response) => response.json())
      .then((data) => setProducts(data))
  }, []) //empty dependency array will make the callback function called once. if not specified it will be called endlessly (since it is going to be called whenever the component is rendered (like when state is changed))

  return (
    <>
      <ProductList products={products}></ProductList>
    </>
  )
}
