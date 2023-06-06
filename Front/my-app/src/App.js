
import axios from "axios";
import React from "react";

const baseURL = "https://localhost:7171/api/Users";

export default function App() {
  // const [post, setPost] = React.useState(null);

  // React.useEffect(() => {
  //   axios.get(`${baseURL}/1`).then((response) => {
  //     setPost(response.data);
  //   });
  // }, []);

  function createPost() {
    axios
      .post(baseURL, {
        id: "1",
        name: "This is a new post."
      })
      .then((response) => {
       console.log(response.data) ;
      });
  }

  

  return (
    <div>
      <h1>CUENTOS INFANTILES</h1>
      <p>Crear Cuentos</p>
      <button onClick={createPost}>Create</button>
    </div>
  );
}