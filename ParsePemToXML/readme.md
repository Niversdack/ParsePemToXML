
### MAC OS install

```shell
dotnet build --output cli && cp -R cli ~/ParsePemToXML | echo "alias pem-to-xml='~/ParsePemToXML/ParsePemToXML'" >> ~/.zshrc && source ~/.zshrc
```

### HOW TO USE
```shell
# path_to_file public or private pem
pem-to-xml {path_to_file} 
#or 
cat {path_to_file} > pem-to-xml
```
