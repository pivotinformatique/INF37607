function App() {
  const name = 'Brad'
  const x = true
  return (
    <div className="container">
      <h1>Hello From React {x ? 'Yes' : 'No'}</h1>
      <h2>Hello {name} {2+2}</h2>
    </div>

  );
}

export default App;
