
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
        title: "Hello World!",
        body: "This is a new post."
      })
      .then((response) => {
        alert("hola");
      });
  }

  

  return (
    <div>
      <h1>hohoh</h1>
      <p>hhoh</p>
      <button onClick={createPost}>Create Post</button>
    </div>
  );
}