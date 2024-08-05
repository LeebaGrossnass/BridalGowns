import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import axios from 'axios';
import Card from 'react-bootstrap/Card';
import Button from 'react-bootstrap/Button';
import 'bootstrap/dist/css/bootstrap.min.css';

const GownList = () => {
  const [gowns, setGowns] = useState([]);

  useEffect(() => {
    fetchGowns();
  }, []);

  const fetchGowns = async () => {
    try {
      const response = await axios.get('http://localhost:5124/api/gowns');
      setGowns(response.data);
    } catch (error) {
      console.error('Error fetching gowns:', error);
    }
  };

  const handleDelete = async (id) => {
    try {
      await axios.delete(`http://localhost:5124/api/gowns/${id}`);
      fetchGowns(); // Refresh the list after deletion
    } catch (error) {
      console.error('Error deleting gown:', error);
    }
  };

  return (
    <div className="container mt-5">
      <h2 className="mb-4">Gown List</h2>
      <div className="row row-cols-1 row-cols-md-3 g-4">
        {gowns.map((gown) => (
          <div className="col" key={gown.gownCode}>
            <Card style={{ backgroundColor: '#f9ecd2', border: 'none', boxShadow: '0 0 10px rgba(0,0,0,0.1)' }}>
              <Card.Img variant="top" src={gown.image} />
              <Card.Body>
                <Card.Title>{gown.name}</Card.Title>
                <Card.Text>{gown.description}</Card.Text>
                <Link to={`/update-gown/${gown.gownCode}`} className="btn btn-warning">Update Gown</Link>
                <Button variant="danger" className="ms-2" onClick={() => handleDelete(gown.gownCode)}>Delete Gown</Button>
              </Card.Body>
            </Card>
          </div>
        ))}
      </div>
      <Link to="/add-gown" className="btn btn-primary mt-4">Add New Gown</Link>
    </div>
  );
};

export default GownList;
