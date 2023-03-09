import { Box, CardContent, TextField } from '@mui/material'
import Button from '@mui/material/Button'
import Card from '@mui/material/Card'
import React from 'react'
import Center from './center'

export default function Register() {
    return (
        <Center>
            <Card sx={{ width: '400px' }}>
                <CardContent sx={{textAlign: 'center'}}>
                    <Box sx={{
                        '& .MuiTextField-root': {
                            margin: '5px',
                            width: '90%'
                        }
                    }}>
                        <form noValidate>
                            <TextField
                                multiline
                                placeholder="Имя"
                                label="Введите имя"
                                name="name"
                                variant="outlined" />
                            <TextField
                                multiline
                                placeholder="Email"
                                label="Email"
                                name="email"
                                variant="outlined" />
                            <TextField
                                multiline
                                placeholder="Пароль"
                                label="Введите пароль"
                                name="password"
                                variant="outlined" />
                            <Button
                                type="submit"
                                variant="contained"
                                size="large"
                                sx={{ width: '90%', margin: '5px'}}>Регистрация</Button>
                        </form>
                    </Box >
                </CardContent>
            </Card>
        </Center>
    )
}
