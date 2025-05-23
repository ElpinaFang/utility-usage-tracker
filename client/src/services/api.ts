import axios from 'axios';

const API_URL = 'http://localhost:5033/api/meterreadings'; // Adjust if your backend runs on a different port
//const API_URL = 'https://tmj4gpwtik.ap-southeast-2.awsapprunner.com/api/meterreadings';

export const getReadings = () => axios.get(API_URL);
export const postReading = (data: any) => axios.post(API_URL, data);
