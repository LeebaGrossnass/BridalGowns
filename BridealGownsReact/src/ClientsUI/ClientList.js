import React, { useEffect, useState } from "react";
import Card from 'react-bootstrap/Card';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import { Link } from 'react-router-dom';
import 'bootstrap/dist/css/bootstrap.min.css';

const ClientList = () => {
  const [clients, setClients] = useState([]);
  const [searchTerm, setSearchTerm] = useState('');
  const [searchResults, setSearchResults] = useState([]);

  useEffect(() => {
    fetchClients();
  }, []);

  const fetchClients = () => {
    fetch('http://localhost:5124/api/clients')
      .then(response => response.json())
      .then(data => setClients(data))
      .catch(error => console.error('Error fetching clients:', error));
  };

  const handleSearch = () => {
    if (searchTerm.trim() !== '') {
      fetch(`http://localhost:5124/api/clients/${searchTerm}`)
        .then(response => response.json())
        .then(data => {
          setSearchResults(data ? [data] : []);
        })
        .catch(error => {
          console.error('Error fetching client:', error);
          setSearchResults([]);
        });
    } else {
      setSearchResults([]);
    }
  };

  const handleChange = (e) => {
    setSearchTerm(e.target.value);
  };

  return (
    <div className="container-fluid" style={{ backgroundColor: '#f3e7da', padding: '20px', minHeight: '100vh' }}>
      <h2 className="mb-4">Client List</h2>
      <Form.Group className="mb-3 d-flex align-items-center justify-content-end">
        <Form.Control 
          type="text" 
          placeholder="Search by name or email" 
          value={searchTerm} 
          onChange={handleChange} 
          className="mr-2" 
          style={{ flex: '1' }} 
        />
        <Button 
          variant="warning" 
          onClick={handleSearch} 
          style={{ backgroundColor: '#edd8c7', borderColor: '#edd8c7', color: '#ffffff' }}
        >
          Search
        </Button>
      </Form.Group>
      <div className="row">
        {(searchTerm.trim() === '' ? clients : searchResults).map(client => (
          <div className="col-md-4 mb-4" key={client.id}>
            <Card style={{ backgroundColor: '#f9ecd2', border: 'none', boxShadow: '0 0 10px rgba(0,0,0,0.1)' }}>
              <Card.Body>
                <Card.Title className="text-dark">{client.firstName} {client.lastName}</Card.Title>
                <Card.Text className="text-dark">
                  Email: {client.email}<br />
                  Phone: {client.phoneNumber}
                </Card.Text>
                <Link to={`/clients/update-client/${client.id}`}>
                  <Button 
                    variant="warning" 
                    style={{ backgroundColor: '#edd8c7', borderColor: '#edd8c7' }}
                  >
                    Update Client
                  </Button>
                </Link>
              </Card.Body>
            </Card>
          </div>
        ))}
      </div>
      <Link to="/clients/add-client">
        <Button 
          variant="warning" 
          style={{ backgroundColor: '#edd8c7', borderColor: '#edd8c7' }}
        >
          Add Client
        </Button>
      </Link>
    </div>
  );
};

export default ClientList;
