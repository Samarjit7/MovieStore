import { List, ListItem, ListItemText, Typography } from "@mui/material";
import axios from "axios";
import { useEffect, useState } from "react";

function App() {
  const [movies, setMovies] = useState<Movie[]>([]);

  useEffect(() => {
    axios.get<Movie[]>('https://localhost:5001/api/movies')
      .then(response => setMovies(response.data))
    
    return () => {}
  }, [])
  
  return (
    <>
    <Typography variant="h3">MovieStore</Typography>
    <List>
      {movies.map((movie) => (
        <ListItem key={movie.id}>
          <ListItemText>{movie.title}</ListItemText>
        </ListItem>
      ))}
    </List>
    </>
  )
}

export default App
